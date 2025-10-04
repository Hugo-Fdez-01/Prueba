using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")]
        public Dictionary<string, GameObject> characterDictionary;

        private void Start() 
        {
            //Iniciar
            characterDictionary = new Dictionary<string, GameObject>();

            //Buscar contenido
            for (int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]);
            }

            //Eliminar contenido
            characterDictionary.Remove("Orc"); //Orc es un ejemplo

            //Contiene un elemento?
            bool contains = characterDictionary.ContainsKey("Orc"); //Orc es un ejemplo

            //Leer
            GameObject myValue = characterDictionary["Orc"]; //Orc es un ejemplo

            //Cantidades
            int amount = characterDictionary.Count;

            //Clear
            characterDictionary.Clear();

        }
    }
}
