using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunGame.Stage
{
    public class Hari : MonoBehaviour
    {
        public float deleteTime = 5.0f;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, deleteTime);
        }

        // Update is called once per frame
        void Update()
        {
            // float speed = 0.05f;　このスピードが元
            float speed = 0.05f;
            transform.Translate(-speed, -speed, 0.0f);
            Debug.Log("speed = " + speed);
        }
        void FixedUpdate()
        {

        }
        void OnTiriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ground")
            {
                Destroy(gameObject);
            }
        }
    }
}