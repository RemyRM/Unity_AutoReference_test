using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using static TestDLLManaged.TestDLLManaged;

public class DLLImportTest : MonoBehaviour
{
    const float pi = 3.1415926535f;

    [DllImport("TestDLL", EntryPoint = "MultiplyNumbers")]
    public static extern float UnmanagedMultiply(int a, float b);

    // Use this for initialization
    void Start()
    {
        UnityEngine.Debug.LogFormat("validating unmanaged, expeceted result = 100: {0}", UnmanagedMultiply(10, 10f));
        UnityEngine.Debug.LogFormat("validating managed, expeceted result = 100:  {0}", Multiply(10, 10f));
        BenchMark();
    }

    private void BenchMark()
    {
        Stopwatch watch1 = new Stopwatch();
        watch1.Start();
        for (int i = 0; i < 10000000; i++)
        {
            UnmanagedMultiply(1574, pi);
        }
        watch1.Stop();
        UnityEngine.Debug.LogFormat("Unmanaged multiply took {0} milliseconds", watch1.Elapsed);

        Stopwatch watch2 = new Stopwatch();
        watch2.Start();
        for (int i = 0; i < 10000000; i++)
        {
            Multiply(1574, pi);
        }
        watch2.Stop();
        UnityEngine.Debug.LogFormat("Managed multiply took {0} milliseconds", watch2.Elapsed);
    }
}