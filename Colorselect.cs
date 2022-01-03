using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Colorselect : MonoBehaviour
{
    
    public Material red;
    public Material purple;
    public Material green;
    public Material blue;
    public Material orange;
    public Material pink;
    public Material yellow;
    public Material lightblue;
    public Material darkgreen;
    public Material brown;
    public Material maroon;
    public Material magenta;
    public Renderer renderCube;
    public Renderer renderParticle;
    public Renderer renderJump;
    public Renderer jumpColorinit;

    public Renderer[] jumps;
   
      
  


    void Start()
    {
        
        if(PlayerPrefs.GetString("color") == "purple")
        {
        renderCube.sharedMaterial = purple;    
        renderParticle.sharedMaterial = purple;    
        renderJump.sharedMaterial = purple;    
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = purple;
        }
        }
        if(PlayerPrefs.GetString("color") == "" | PlayerPrefs.GetString("color") == "red")
        {
        renderCube.sharedMaterial = red;    
        renderParticle.sharedMaterial = red;    
        renderJump.sharedMaterial = red;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = red;
        } 
        }
        if(PlayerPrefs.GetString("color") == "green")
        {
        renderCube.sharedMaterial = green;    
        renderParticle.sharedMaterial = green;    
        renderJump.sharedMaterial = green;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = green;
        } 
        }
        if(PlayerPrefs.GetString("color") == "blue")
        {
        renderCube.sharedMaterial = blue;    
        renderParticle.sharedMaterial = blue;    
        renderJump.sharedMaterial = blue;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = blue;
        } 
        }
        if(PlayerPrefs.GetString("color") == "orange")
        {
        renderCube.sharedMaterial = orange;    
        renderParticle.sharedMaterial = orange;    
        renderJump.sharedMaterial = orange;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = orange;
        } 
        }
        


        if(PlayerPrefs.GetString("color") == "pink")
        {
        renderCube.sharedMaterial = pink;    
        renderParticle.sharedMaterial = pink;    
        renderJump.sharedMaterial = pink;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = pink;
        } 
        }
        if(PlayerPrefs.GetString("color") == "yellow")
        {
        renderCube.sharedMaterial = yellow;    
        renderParticle.sharedMaterial = yellow;    
        renderJump.sharedMaterial = yellow;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = yellow;
        } 
        }
        if(PlayerPrefs.GetString("color") == "lightblue")
        {
        renderCube.sharedMaterial = lightblue;    
        renderParticle.sharedMaterial = lightblue;    
        renderJump.sharedMaterial = lightblue;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = lightblue;
        } 
        }
        if(PlayerPrefs.GetString("color") == "darkgreen")
        {
        renderCube.sharedMaterial = darkgreen;    
        renderParticle.sharedMaterial = darkgreen;    
        renderJump.sharedMaterial = darkgreen;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = darkgreen;
        } 
        }
        if(PlayerPrefs.GetString("color") == "brown")
        {
        renderCube.sharedMaterial = brown;    
        renderParticle.sharedMaterial = brown;    
        renderJump.sharedMaterial = brown;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = brown;
        } 
        }
        if(PlayerPrefs.GetString("color") == "maroon")
        {
        renderCube.sharedMaterial = maroon;    
        renderParticle.sharedMaterial = maroon;    
        renderJump.sharedMaterial = maroon;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = maroon;
        } 
        }
        if(PlayerPrefs.GetString("color") == "magenta")
        {
        renderCube.sharedMaterial = magenta;    
        renderParticle.sharedMaterial = magenta;    
        renderJump.sharedMaterial = magenta;   
        for(int i = 0 ; i < jumps.Length ; ++i)
        {
            jumps[i].sharedMaterial = magenta;
        } 
        }










        
        
    }


}
