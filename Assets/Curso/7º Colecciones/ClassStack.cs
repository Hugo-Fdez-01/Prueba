using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassStack : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardStack;

        private void Start() 
        {
            //Iniciar
            cardStack = new Stack<GameObject>();

            //Añadir
            for (int i = 0; i < myContent.Length; i++)
            {
                cardStack.Push(myContent[i]);
            }

            //Obtener el primer el elemento y eliminarlo
            GameObject mygameObjectPop = cardStack.Pop();

            //Obtener el primer el elemento
            GameObject mygameObjectPeek = cardStack.Peek();

            //Contiene?
            bool contains = cardStack.Contains(mygameObjectPeek);
            
            //Cantidad
            int amount = cardStack.Count;

            //Eliminar Stack
            cardStack.Clear();

        }
    }
}
