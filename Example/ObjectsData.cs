using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object Data", menuName = "Object Data")]
public class ObjectsData : ScriptableObject
{
    [SerializeField] private string objectName;
    [SerializeField] private string objectDescription;
    [SerializeField] private InteractableType interactableType;
    [SerializeField] private Sprite UISprite;
    [SerializeField] private Vector3 UIPosition;

    public string GetObjectName { get { return objectName; } }
    public string GetObjectDescription { get { return objectDescription; } }
    public InteractableType GetInteractableType { get { return interactableType; } }
    public Sprite GetUISprite { get { return UISprite; } }
    public Vector3 GetUIPosition { get { return UIPosition; } }

}
