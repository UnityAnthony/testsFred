using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class NewFredTestScript
{

    // A Test behaves as an ordinary method
    [Test]
    public void NewFredTestScriptSimplePasses()
    {

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewFredTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        yield return new WaitForSeconds(1);

        Fred f = GameObject.FindObjectOfType<Fred>();
        if (f)
        {
            Debug.Log("got fred");
            //Debug.Log(f.bu);
            Assert.True(f.but);
        }
        else
        {
            Debug.Log("NO fred");
        }

    }
}
