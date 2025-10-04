using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassList : MonoBehaviour
    {
        [Header("Content")]
        public int[] myContent;

        [Header("List")]
        public List<int> weaponList;

        private void Start()
        {
            //Iniciar la lista
            weaponList = new List<int>();

            //Operacion de agregar elementos a la lista

                //1º
            for (int i = 0; i < myContent.Length; i++)
            {
                weaponList.Add(myContent[i]);
            }

                //2º
            weaponList.AddRange(myContent);

            //Quitar elementos
            weaponList.Remove(myContent[2]);

            //Leer
            int tempValue = weaponList[2];

            //Cantidad
            int amount = weaponList.Count;

            //Clear
            weaponList.Clear();
        }

    }
}
