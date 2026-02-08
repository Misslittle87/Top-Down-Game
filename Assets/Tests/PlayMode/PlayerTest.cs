using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

public class PlayerTests
{
    [UnityTest]
    public IEnumerator SceneTransition()
    {
        var gameObject = new GameObject();
        var sceneTransition = gameObject.AddComponent<SceneTransition>();
        yield return sceneTransition;
    }
    public IEnumerator PlayerMovement()
    {
        var gameObject = new GameObject();
        var player = gameObject.AddComponent<Player>();
        //player.Movement();

        yield return new WaitForSeconds(1);

        Assert.AreEqual(expected: new Vector3 (0, 1, 0), actual: gameObject.transform.position);
    }

}
