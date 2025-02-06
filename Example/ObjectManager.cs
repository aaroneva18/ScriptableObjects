
    using System;
    using UnityEngine;

    public class ObjectManager : MonoBehaviour
    {
        [SerializeField] private InteractableType interactableType;
        [SerializeField] private ObjectsData objectData;

        private void Awake() {
            objectData.SetObjectID();
            Debug.Log(objectData.GetObjectID);
        }

        public InteractableType GetInteractableType { get { return interactableType; } }

    }
