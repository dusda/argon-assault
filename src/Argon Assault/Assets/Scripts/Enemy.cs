using UnityEngine;

[DisallowMultipleComponent]
public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 10;
    [SerializeField] int hits = 10;

    ScoreBoard _scoreBoard;

    void Start()
    {
        AddBoxCollider();
        _scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        Collider collider = gameObject.AddComponent<BoxCollider>();
        collider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();

        if (hits <= 0)
            Kill();
    }

    void ProcessHit()
    {
        _scoreBoard.ScoreHit(scorePerHit);
        hits -= 1;
    }

    void Kill()
    {
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
