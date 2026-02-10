using UnityEngine;

namespace Assets._Project.Script.Combat
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : MonoBehaviour
    {
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void Launch(Vector2 direction, float speed)
        {
            rb.velocity = direction.normalized * speed;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle -90f, Vector3.forward);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
