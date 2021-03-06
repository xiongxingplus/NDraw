﻿using UnityEngine;

using NDraw;

public class NDrawExample : MonoBehaviour
{
    public bool screenExamples = true;
    public bool worldExamples = true;

    Vector2[] multilinePoints;

    void Start()
    {
        multilinePoints = new Vector2[100];

        for (int i = 0; i < multilinePoints.Length; i++)
        {
            multilinePoints[i] = new Vector2(200, 400) + Random.insideUnitCircle * 200;
        }
    }

    void Update()
    {
        if (screenExamples)
        {
            Draw.Screen.Line(140, 10, 240, 200);
            Draw.Screen.SetColor(Color.black);
            Draw.Screen.Line(new Vector2(150, 10), new Vector2(250, 200));

            Draw.Screen.SetColor(Color.blue);
            Draw.Screen.Ellipse(new Vector2(500, 500), new Vector2(100, 200));

            Draw.Screen.SetColor(Color.cyan);
            Draw.Screen.Ellipse(new Vector2(550, 500), new Vector2(130, 200));

            Draw.Screen.SetColor(Color.yellow);
            Draw.Screen.Rect(10, 10, 100, 200);
            Draw.Screen.SetColor(Color.cyan);
            Draw.Screen.Rect(new Rect(20, 20, 100, 200));

            Draw.Screen.SetColor(Color.red);
            Draw.Screen.MultiLine(multilinePoints);

            Draw.Screen.SetColor(Color.yellow);
            Draw.Screen.Circle(600, 230, 200);

            Draw.Screen.Grid(10, 10, new Rect(600, 100, 250, 200));

            Draw.Screen.SetFillColor(new Color(0, 1, 0, 0.1f));
            Draw.Screen.FillRect(500, 500, 100, 200);

            Draw.Screen.SetFillColor(new Color(0, 1, 1, 0.1f));
            Draw.Screen.FillRect(100, 500, 100, 200);

            float pieValue = Mathf.Sin(Time.time / 2) * 2;
            if (pieValue < 0)
                Draw.Screen.SetFillColor(new Color(1, 0, 0, 0.5f));
            else Draw.Screen.SetFillColor(new Color(1, 0.5f, 0, 0.5f));

            Draw.Screen.Pie(200, 200, 20, 40, pieValue);
            // outline test
            //Draw.Screen.SetFillColor(Color.black);
            //Draw.Screen.Pie(200, 200, 19, 20, pieValue);
            //Draw.Screen.Pie(200, 200, 40, 41, pieValue);

            Draw.Screen.Pie(200, 200, 45, 50, -pieValue);

            Draw.Screen.Slider(pieValue * 0.5f, 200, 50, Color.red, 200);
            Draw.Screen.MidSlider(pieValue * 0.5f, 200, 60, Color.blue, 200);
        }

        // 3D

        if (worldExamples)
        {
            Draw.World.Line(Vector3.zero, Vector3.forward * 100);

            Draw.World.SetColor(Color.magenta);
            Draw.World.Cube(Vector3.zero, Vector3.one * 10, Vector3.forward, Vector3.up);

            Draw.World.SetColor(Color.red);
            Draw.World.Cube(Vector3.zero, Vector3.one, Vector3.forward, Vector3.up);

            Draw.World.Circle(Vector3.forward * 5, 10, Vector3.up);
            Draw.World.SetColor(Color.cyan);
            Draw.World.Circle(Vector3.right * 5, 10, Vector3.up);

            Draw.World.SetColor(new Color(0, 1, 0, 0.4f));
            for (float e = 0.1f; e < 1.6f; e += 0.1f)
            {
                Draw.World.ConicSectionUsingApses(new Vector3(1, 1, 1), 1, e * 10, Vector3.forward, Vector3.right, 40);
            }
        }
    }
}
