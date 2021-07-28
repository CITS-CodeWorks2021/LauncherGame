using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Data/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public int weight;
    public int value;
}
