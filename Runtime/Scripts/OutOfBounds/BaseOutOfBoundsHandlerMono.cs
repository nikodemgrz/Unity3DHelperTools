using NaughtyAttributes;
using NikosAssets.Helpers.AlarmClock;
using NikosAssets.Helpers.Extensions;
using UnityEngine;

namespace NikosAssets.Helpers.OutOfBounds
{
    public abstract class BaseOutOfBoundsHandlerMono : BaseNotesMono
    {
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected Transform _target;

        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected Rigidbody[] _rigidbodiesToResetVelocity;
        
        /// <summary>
        /// The interval to check if the <see cref="_target"/> is out of bounds
        /// </summary>
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        [Tooltip("The interval to check if the " + nameof(_target) + " is out of bounds")]
        protected AlarmClockMono _alarmClockMono;
        
        /// <summary>
        /// When resetting the <see cref="_target"/> on the surface, this is the y offset
        /// </summary>
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        [Tooltip("When resetting the " + nameof(_target) + " on the surface, this is the y offset")]
        protected float _yResetPosOffset = 3f;

        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected LayerMask _allowedLayersToCheck;
        
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected float _groundDistanceCheck = 4000;
        
        /// <summary>
        /// The origin height to shoot the surface checker raycast from
        /// </summary>
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        [Tooltip("The origin height to shoot the surface checker raycast from")]
        protected float _shootRayFromGlobalYPos = 100;

        protected virtual void OnEnable()
        {
            _alarmClockMono.OnAlarm += Tick;
        }

        protected virtual void OnDisable()
        {
            _alarmClockMono.OnAlarm -= Tick;
        }

        /// <summary>
        /// Resets the <see cref="_target"/> by shooting a ray from top to bottom and placing the <see cref="_target"/>
        /// on top of the hit position with the <see cref="_yResetPosOffset"/>.
        /// If no surface was found, reset the <see cref="_target"/> at the <see cref="_yDefaultValueOnNoHit"/> height.
        /// </summary>
        public virtual void ResetPos()
        {
            Vector3 tPos = _target.position;
            Vector3 rayOriginPoint = tPos.GetWithNewY(_shootRayFromGlobalYPos);

            if (!Physics.Raycast(rayOriginPoint, Vector3.down, out RaycastHit hit, _groundDistanceCheck, _allowedLayersToCheck)) 
                return;
            
            _target.position = hit.point + (Vector3.up * _yResetPosOffset);
            foreach (Rigidbody rb in _rigidbodiesToResetVelocity)
                rb.linearVelocity = rb.linearVelocity.GetWithNewY(0);
        }
        
        public abstract void Tick();
    }
}
