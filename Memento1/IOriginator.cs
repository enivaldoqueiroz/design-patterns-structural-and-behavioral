﻿namespace Memento1;

public interface IOriginator
{
    //Permite o Originator restaurar o seu estado
    int GetPrimeiroNumero();
    int GetSegundoNumero();
}