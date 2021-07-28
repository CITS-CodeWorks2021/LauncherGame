using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    public DataToSave infoToSave;
    public SomeScores highScores;
    public string saveName;
    
    string path, filePath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SaveData()
    {
        path = Application.dataPath;
        filePath = path + "/" + saveName + ".data";

        BinaryFormatter formatter = new BinaryFormatter();

        FileStream file = File.Open(filePath, FileMode.Create);

        formatter.Serialize(file, infoToSave);

        file.Close();
    }

    public void LoadData()
    {
        path = Application.dataPath;
        filePath = path + "/" + saveName + ".data";

        if (File.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream file = File.Open(filePath, FileMode.Open);

            infoToSave = (DataToSave)formatter.Deserialize(file);

            file.Close();
        }

    }

    void PositionToSaveExample()
    {
        PositionSave position = new PositionSave();
        position.values[0] = transform.position.x;
        position.values[1] = transform.position.y;
        position.values[2] = transform.position.z;
    }
}

[System.Serializable]
public class DataToSave
{
    public string aName;
    public int aNumber;
    public List<float> SomeFloats;
}

[System.Serializable]
public struct SomeScores
{
    public List<int> highScores;
}

[System.Serializable]
public class Currency
{
    public int howMuch;
}

[System.Serializable]
public class PositionSave
{
    public float[] values;
}