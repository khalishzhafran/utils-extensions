// Author   : Litsch

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Litsch.Utilities
{
    /// <summary>
    /// Provides extension methods for coroutines to handle multiple coroutine operations.
    /// </summary>
    public static class CoroutineExtension
    {
        /// <summary>
        /// Waits until all the provided coroutines have completed.
        /// </summary>
        /// <param name="monoBehaviour">The MonoBehaviour instance that starts the coroutines.</param>
        /// <param name="coroutines">An array of coroutines to wait for.</param>
        /// <returns>An IEnumerator that waits for all the provided coroutines to complete.</returns>
        public static IEnumerator WaitAll(this MonoBehaviour monoBehaviour, params IEnumerator[] coroutines)
        {
            return new WaitAll(monoBehaviour, coroutines);
        }

        /// <summary>
        /// Waits until any one of the provided coroutines has completed.
        /// </summary>
        /// <param name="monoBehaviour">The MonoBehaviour instance that starts the coroutines.</param>
        /// <param name="coroutines">An array of coroutines to wait for.</param>
        /// <returns>An IEnumerator that waits for any one of the provided coroutines to complete.</returns>
        public static IEnumerator WaitAny(this MonoBehaviour monoBehaviour, params IEnumerator[] coroutines)
        {
            return new WaitAny(monoBehaviour, coroutines);
        }

        /// <summary>
        /// Waits for a UnityEvent to be triggered.
        /// </summary>
        /// <param name="unityEvent">The UnityEvent to wait for.</param>
        /// <returns>An IEnumerator that waits until the UnityEvent is triggered.</returns>
        public static IEnumerator WaitForEvent(this UnityEvent unityEvent)
        {
            bool isTriggered = false;

            unityEvent.AddListener(Trigger);
            yield return new WaitUntil(() => isTriggered);
            unityEvent.RemoveListener(Trigger);

            void Trigger() => isTriggered = true;
        }
    }
}
