using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float explosionRadius = 50.0f;
    public float explosionForce = 10f;

    private Rigidbody rBody;
    private RaycastHit2D[] hits;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody>();

        hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);

        foreach (RaycastHit2D h in hits)
        {
            if (h.transform.gameObject.tag == "Robot")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
        }

        Destroy(this.gameObject, 1f);
    }
}
