using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    Stack<GameObject> myMenuStack = new Stack<GameObject>();
    public GameObject startView;
    private GameObject currView;
    // Start is called before the first frame update
    private void Start()
    {
        myMenuStack.Push(startView);
        DisplayView();
    }
    void DisplayView()
    {
        currView = myMenuStack.Peek();
        currView.SetActive(true);
    }

    public void AddStack(GameObject view)
    {
        currView.SetActive(false);
        myMenuStack.Push(view);
        DisplayView();
    }

    public void RemoveStack()
    {
        GameObject hideMenu = myMenuStack.Pop();
        hideMenu.SetActive(false);
        DisplayView();
    }
}
