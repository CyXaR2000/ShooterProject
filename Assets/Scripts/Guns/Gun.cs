using UnityEngine;

[RequireComponent(typeof(RayShooter))]
public class Gun : MonoBehaviour
{
    [SerializeField] InputReader _inputReader;
    [SerializeField] SpriteAnimator _spriteAnimator;
    [SerializeField] private AudioSource _fireShot;
    [SerializeField] private AudioSource _recharge;

    private RayShooter _rayShooter;

    private void Awake()
    {
        _rayShooter = GetComponent<RayShooter>();

    }


    private void OnEnable()
    {
        _inputReader.ZeroMouseButtomPressed += _rayShooter.Fire;
        _inputReader.ZeroMouseButtomPressed += _spriteAnimator.Shot;
        _inputReader.MoveButtonPressed += _spriteAnimator.Walk;
    }

    private void OnDisable()
    {
        _inputReader.ZeroMouseButtomPressed -= _rayShooter.Fire;
        _inputReader.ZeroMouseButtomPressed -= _spriteAnimator.Shot;
        _inputReader.MoveButtonPressed -= _spriteAnimator.Walk;
    }

    public void FireSource()
    {
        _fireShot.Play();
    }

    public void RechargeSource()
    {
        _recharge.Play();
    }
}
