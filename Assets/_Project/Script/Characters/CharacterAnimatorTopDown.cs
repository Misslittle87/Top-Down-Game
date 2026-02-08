using UnityEngine;

namespace Assets._Project.Script.Characters
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(BaseMovement))]
    public class CharacterAnimatorTopDown : MonoBehaviour
    {
        private Animator animator;
        private BaseMovement movement;

        private Vector2 lookDirection = new Vector2(0, -1);

        private void Awake()
        {
            animator = GetComponent<Animator>();
            movement = GetComponent<BaseMovement>();
        }

        private void Update()
        {
            Vector2 move = movement.MoveDirection;

            if (move.x > 0.01f)
                transform.localScale = Vector3.one;
            else if (move.x < -0.01f)
                transform.localScale = new Vector3(-1, 1, 1);

            if (move.sqrMagnitude > 0.001f)
            {
                lookDirection = move.normalized;
            }
            animator.SetFloat("Horizontal", lookDirection.x);
            animator.SetFloat("Vertical", lookDirection.y);

            animator.SetFloat("Speed", move.sqrMagnitude);
        }
    }
}
