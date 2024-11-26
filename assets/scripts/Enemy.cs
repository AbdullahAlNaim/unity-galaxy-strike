using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedVFX;

    
    private void OnParticleCollision(GameObject other) {
        // This brings the explosion particles into existance at position of this.gameObjects
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
