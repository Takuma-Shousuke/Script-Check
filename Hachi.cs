using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace RunGame.Stage
{
    public class Hachi : MonoBehaviour
    {
        public float span = 2f;
        private float currentTime = 0f;
        public float move = 4f;
        private float moveTime = 0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            currentTime += Time.deltaTime;
            if (currentTime > span)
            {
                GameObject prefab = (GameObject)Resources.Load("Hari2");
                if (prefab != null)
                {
                    Instantiate(prefab, transform.position, Quaternion.identity);
                }
                currentTime = 0f;
            }


        }

        void FixedUpdate()
        {
            float sin = Mathf.Sin(2 * Time.time);

            this.transform.position = new Vector3(0f, 2 * sin);

        }
    }
}
