using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// Start by calling all of the libraries that we are going to use.
// These are the default libraries, with UnityEngine.AI added because we are using a NavMeshAgent.

public class PotatoMovement : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent PotatoAgent;
    Renderer PotatoRenderer;

    Color PotatoColor;
    public Color AngryColor;

    GameObject[] Bookshelves;
    Transform waitPlace;
    GameObject[] bookshelvesPlaces;
    Transform checkPlace;
    Transform exitPlace;
    GameObject[] Potatoes;

    public int WantedBook;
    float TimeUntilScan = 1f;
    // Get all of the private variables that we are going to use in this script.
    // We are using a NavMeshAgent to move the Potato automatically.
    // A Renderer to change the color of the Potato during runtime.
    // A Color to change the Potato back to its original color when we are done.
    // And a Vector 3 to place the Potato back to its starting position when the loop is done.

    // Then get all of the public variables that we will use.
    // We are using an array of GameObjects that will be the Bookshelves to click on for the Potato to move to.
    // Two different Transforms, for the spot where the Potato will ask and check out their books.
    // And an array of Transforms that is our bookshelvesPlaces lining up with the array of bookshelves.

    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();
        PotatoRenderer = GetComponent<Renderer>();
        PotatoColor = new Color(0.6226414f, 0.3826481f, 0.1139551f, 1f);
        AngryColor = new Color(0.471f, 0.024f, 0.024f, 1f);
        // When the game starts, we first define all of the private variables that we need for this script.
        // We get the NavMeshAgent and Renderer components for PotatoAgent and PotatoRenderer respectively.
        // We create a new Color for PotatoColor, which is the color the Potato starts with.
        // And we set the Vector3 of PotatoStartPlace to where the Potato currently is when the game starts.

        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        Bookshelves = GameObject.FindGameObjectsWithTag("Bookshelves");
        waitPlace = GameObject.FindGameObjectWithTag("WaitPlace").transform;
        bookshelvesPlaces = GameObject.FindGameObjectsWithTag("BookshelvesMarkers");
        checkPlace = GameObject.FindGameObjectWithTag("CheckPlace").transform;
        exitPlace = GameObject.FindGameObjectWithTag("ExitPlace").transform;

        WantedBook = Random.Range(0, 4);

        PotatoAgent.SetDestination(waitPlace.position);
        // Then we set our NavMeshAgent's destination to the position of our waitPlace.
        // It's VERY IMPORTANT that you place the starting SetDestination here!!
        // If you place this in FixedUpdate, when you click to update the destination of the Potato, the next frame it will default back to the waitPlace.
    }

    // Update is called once per frame
    void FixedUpdate()
    // Used FixedUpdate since we are using Physics-based movement.
    {
        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            TimeUntilScan = 1f;
        }

        Ray spell = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit spellImpactReport = new RaycastHit();
        // When the game updates, first we create our Ray and RaycastHit since our game will be controlled by Raycasting.

        if (Physics.Raycast(spell, out spellImpactReport))
        // We create a conditional statement that will be true whenever our Raycast Hits an object.
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            // We create a conditional statement that will be true whenever the left mouse button is clicked.
            {
                if (gameObject.transform.position.x == waitPlace.position.x && spellImpactReport.collider == gameObject.GetComponent<Collider>())
                // We create a conditional statement once we click the left mouse button.
                // That will be true whenever the Potato's X position is equal to the waitPlace's X position.
                // AND when the collider of the object the Raycast hit is equal to the Potato's collider.
                // I personally used the X position of the Potato because when the game runs, the Potato's Y position changes to 1.00008.
                // This makes gameObject.transform.position == waitPlace.position false.
                // We must also use spellImpactReport.collider to specify the object, otherwise the script would run wherever you click on the screen.
                {
                    if (PotatoRenderer.material.color == PotatoColor)
                    {
                        PotatoRenderer.material.SetColor("_Color", Color.yellow);
                    }
                    Debug.Log("Potato wants to go to " + Bookshelves[WantedBook]);
                }

                for (int i = 0; i < Bookshelves.Length; i++)
                {
                    if (PotatoRenderer.material.color == Color.yellow && spellImpactReport.collider == Bookshelves[i].GetComponent<Collider>())
                    {
                        if (spellImpactReport.collider == Bookshelves[WantedBook].GetComponent<Collider>())
                        {
                            PotatoRenderer.material.SetColor("_Color", PotatoColor);
                            PotatoAgent.SetDestination(bookshelvesPlaces[WantedBook].transform.position);
                        }

                        else
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                for (int j = 0; j < Potatoes.Length; j++)
                {
                    if (spellImpactReport.collider == Potatoes[j].GetComponent<Collider>() && Potatoes[j].GetComponent<Renderer>().material.color == AngryColor)
                    {
                        Potatoes[j].GetComponent<NavMeshAgent>().SetDestination(checkPlace.transform.position);
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                for (int j = 0; j < Potatoes.Length; j++)
                {
                    if (spellImpactReport.collider == Potatoes[j].GetComponent<Collider>())
                    {
                        Destroy(Potatoes[j]);
                    }
                }
            }
        }
        // Once we use our Raycast to select the Potato and send it to one of the Bookshelves to collect a book, the rest of the process is automated with our NavMeshAgent.

        for (int i = 0; i < bookshelvesPlaces.Length; i++)
        // We create another for loop, this time for our bookshelvesPlaces.
        {
            if (gameObject.transform.position.x == bookshelvesPlaces[i].transform.position.x && gameObject.transform.position.z == bookshelvesPlaces[i].transform.position.z)
            // We create a conditional statement that will be true whenever the Potato's X & Z position is equal to the bookshelvesPlaces X & Z position.
            // Having it be just one of the positions is fine, I just did both for the added security, since the X & Z positions line up.
            // If this causes me issues down the line, I will switch to check just one.
            {
                if (bookshelvesPlaces[i] == bookshelvesPlaces[0])
                // We create a set of conditional statements that will be run once the Potato reaches its destination.
                // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[0].
                // Or the first bookshelfPlace in the array.
                {
                    PotatoRenderer.material.SetColor("_Color", Color.red);
                    // We use the Renderer to change the Potato's color to red, signifying that it has collected the book that it wanted.
                    // The colors are different just to represent the different genres of books. Red is an action book.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[1])
                // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[1].
                // Or the second bookshelfPlace in the array.
                {
                    PotatoRenderer.material.SetColor("_Color", Color.black);
                    // We use the Renderer to change the Potato's color to black, signifying that it has collected the book that it wanted.
                    // Black is a horror book.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[2])
                // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[2].
                // Or the third bookshelfPlace in the array.
                {
                    PotatoRenderer.material.SetColor("_Color", Color.cyan);
                    // We use the Renderer to change the Potato's color to cyan, signifying that it has collected the book that it wanted.
                    // Cyan is a romance book, will probably change the color to magenta down the line.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[3])
                // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[3].
                // Or the fourth bookshelfPlace in the array.
                {
                    PotatoRenderer.material.SetColor("_Color", Color.grey);
                    //We use the Renderer to change the Potato's color to grey, signifying that it has collected the book that it wanted.
                    //Grey is a non-fiction book.
                }
            }
        }
        if (gameObject.transform.position.x == checkPlace.transform.position.x && gameObject.transform.position.z == checkPlace.transform.position.z)
        {
            PotatoRenderer.material.SetColor("_Color", PotatoColor);
            PotatoAgent.SetDestination(exitPlace.transform.position);
        }

        if (gameObject.transform.position.x == exitPlace.transform.position.x && gameObject.transform.position.z == exitPlace.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}

