using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object Data", menuName = "Object Data")]
public class ObjectsData : ScriptableObject
{
    [SerializeField] private string objectName;
    [SerializeField] private string ObjectID;
    [SerializeField] private string objectDescription;
    [SerializeField] private InteractableType interactableType;

    public string GetObjectName { get { return objectName; } }
    public string GetObjectDescription { get { return objectDescription; } }
    public string GetObjectID { get { return ObjectID; } }
    public InteractableType GetInteractableType { get { return interactableType; } }

    public void SetObjectID() {
        ObjectID = objectName + Time.time + Random.Range(0, 1000);
    }

}
