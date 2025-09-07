﻿namespace Observer1;

public interface ISubject
{
    void RegistrarObserver(IObserver observer);
    void RemoverObserver(IObserver observer);
    void NotificarObservers();
}