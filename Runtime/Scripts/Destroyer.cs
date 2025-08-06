using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace NikosAssets.Helpers
{
    public class Destroyer : BaseNotesMono
    {
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        private List<GameObject> _gameObjectsToDestroy = new List<GameObject>();
        
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        private List<Component> _componentsToDestroy = new List<Component>();

        public void DestroyAll()
        {
            DestroyComponents();
            DestroyGameObjects();
        }

        public void DestroyGameObjects()
        {
            foreach (GameObject go in _gameObjectsToDestroy)
                Destroy(go);
        }
        
        public void DestroyComponents()
        {
            foreach (Component comp in _componentsToDestroy)
                Destroy(comp);
        }
    }
}
