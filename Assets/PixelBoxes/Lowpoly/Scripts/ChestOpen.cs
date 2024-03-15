using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelBoxes.Lowpoly {

    /// <summary>
    /// Opens boxes and dispenses loot!
    /// </summary>
    public class ChestOpen : MonoBehaviour {

        [Header("Box Contentts")]
        [Tooltip("What pickup is in the chest?")]
        //public Loot loot;

        Animator m_Animator;

        void Awake() {
            // Cache Animator Component
            m_Animator = GetComponent<Animator>();
        }

        /// <summary>
        /// void OnTriggerEnter(Collider collider) {
        ///     DoorKey doorKey = collider.GetComponent<DoorKey>();
        ///
        ///}
        /// </summary>

        public void OpenDoor() {
            // Play Open Box Animation
            m_Animator.SetTrigger("01");
        }

        public void CloseDoor() {
            // Play Close Box Animation
            m_Animator.SetTrigger("Close");
        }

    }

}