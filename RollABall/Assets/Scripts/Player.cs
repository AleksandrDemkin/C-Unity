using System;
using UnityEngine;

namespace RollABall
{

    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 3.0f;
        private Rigidbody _rigidbody;
        [SerializeField] private bool _isGorounded;
        [SerializeField] private bool _trigger = false;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            _rigidbody.AddForce(movement * _speed);
        }
        protected void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _isGorounded)
            {
                _isGorounded = false;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 600, 0));
            }
        }
        public void Accelerate ()
        {
            _speed = _speed + 5;
        }
        protected void OnCollisionEnter(Collision other)
        { 
            _isGorounded = true;
            // if (Collision.bonus.CompareTag("Good bonus") && _trigger = true)
            // {
            //     Accelerate();
            //     Debug.Log("Got GoodBonus + 5");
            // }
            // else if (Collision.bonus.CompareTag("Bad bonus") && _trigger = true)
            // {
            //     Accelerate();
            //     Debug.Log("Hit the wall");
            // }
        }
        
        protected void OnTriggerEnter()
        {
            _trigger = true;
            Accelerate();
        }
    }
}