﻿namespace TemplateMethod1;

// Classe Concreta
public class VideoMP4  : VideoPlayer
{
    public override void DecodeVideoFormato()
    {
        Console.WriteLine("O video esta sendo processado com o Decoder MP4");
    }
}