using UnityEngine;

/// <summary>
/// Rigidbody2D と HingeJoint2D に足場の回転を委ねる。
/// Transform の角度を直接操作して物理結果を上書きしない。
/// </summary>
public sealed class PlatformPhysics2D : MonoBehaviour
{
    // 予定: public Rigidbody2D Rigidbody { get; }
    // 予定: public HingeJoint2D Joint { get; }
    // 予定: public Collider2D SurfaceCollider { get; }
    // 予定: public float CurrentAngle { get; }
    // 予定: public float AngularVelocity { get; }

    // 予定: public void Initialize(PlatformData data)
    // データと必要コンポーネントの null を確認し、質量・角度制限・表面材を設定する。

    // 予定: public void EnablePhysics()
    // 予定: public void DisablePhysics()
    // 停止中の回転速度と接触物の扱いは実装時に確認する。
}
