using TMPro;
using UnityEngine;

public class GameMenuUI : MonoBehaviour
{
    public TextMeshProUGUI welcomeText;
    public GameObject errorObject;
    private GameObject currentObject;
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public TMP_InputField xInputField;
    public TMP_InputField yInputField;
    public float xSpawn;
    public float ySpawn;
    private float minXSpawn = -10;
    private float maxXSpawn = 10;
    private float minYSpawn = -5;
    private float maxYSpawn = 5;
    private bool canSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(DataManager.Instance != null)
        {
            welcomeText.text = "Welcome, " + DataManager.Instance.nameText + "!";
        }
        else 
        {
            welcomeText.text = "Name Not Initialized";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickCube()
    {
        currentObject = cube;
        SpawnObject();
    }

    public void OnClickSphere()
    {
        currentObject = sphere;
        SpawnObject();
    }

    public void OnClickCapsule()
    {
        currentObject = capsule;
        SpawnObject();
    }

    private void SpawnObject()
    {
        GetSpawnPos();

        if (canSpawn)
        {
            Instantiate(currentObject, new Vector3(xSpawn, ySpawn, 0), currentObject.transform.rotation);
            errorObject.SetActive(false);
        }
        else
        {
            errorObject.SetActive(true);
        }
    }

    private void GetSpawnPos()
    {
        if (float.TryParse(xInputField.text, out xSpawn) && float.TryParse(yInputField.text, out ySpawn))
        {
            if (xSpawn >= minXSpawn && xSpawn <= maxXSpawn && ySpawn >= minYSpawn && ySpawn <= maxYSpawn)
            {
                Debug.Log("Spawn Pos In Range!");
                canSpawn = true;
            }
            else
            {
                Debug.Log("Spawn Pos Out of Range!");
                canSpawn = false;
            }
        }
        else
        {
            Debug.Log("X and Y spawn must be valid numerical values!");
            canSpawn = false;
        }
    }
}
