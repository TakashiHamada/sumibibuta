using System.IO;
using UnityEngine;
using System.Collections;

public class Memo : MonoBehaviour{
    
    private string stock;
    
    public void Log(string txt) {
        SaveText(txt);
    }
    
    public void Log(Vector3 pos) {
        SaveText(pos.ToString("G4"));
    }
    
    private void SaveText(string txt){
        stock += txt + "\n";
	    StreamWriter sw = new StreamWriter("Log.txt",false);
	    sw.WriteLine(stock);
	    sw.Flush();
	    sw.Close();
    }
}
