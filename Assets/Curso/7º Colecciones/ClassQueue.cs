using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassQueue : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;

        private void Start() 
        {
            //Iniciar
            playerQueue = new Queue<GameObject>();

            //Añadir
            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]);
            }

            //Eliminar a la primera persona de la fila
            GameObject myGameObject = playerQueue.Dequeue(); 
            
            //Lo contiene?
            bool contains = playerQueue.Contains(myGameObject);

            //Amontonar
            int amount = playerQueue.Count;

            //Eliminar Queue
            playerQueue.Clear();
        }
    }
}
