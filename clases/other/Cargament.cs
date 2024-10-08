﻿using System;
using System.Collections.Generic;
using System.Linq;


public class Cargament
{
    private int _cargamentID;
    private Base _destination;
    private List<Item> _listContents = new List<Item>();


    public int CargamentID { get => _cargamentID; set => _cargamentID = value; }
    public Base Destination { get => _destination; set => _destination = value; }
    public List<Item> ListContents { get => _listContents; set => _listContents = value; }

    public Cargament(int cargamentID, Base destination, List<Item> listContents)
    {
        _cargamentID = ListGlosary.listCargaments.Count;
        _destination = destination;
        _listContents = listContents;
        ListGlosary.listCargaments.Add(this);
    }
    public Cargament()
    {
        _cargamentID = ListGlosary.listCargaments.Count;
        _listContents = new List<Item>();
        ListGlosary.listCargaments.Add(this);
    }
    public override string ToString()
    {
        return _cargamentID.ToString();
    }
    public void Allocate()
    {
        Console.WriteLine("entre al metodo");
        if (ListContents == null)
        {
            Console.WriteLine("ListContents es null");
            return; // Termina la ejecución del método si la lista es null.
        }

        if (!ListContents.Any())
        {
            Console.WriteLine("ListContents está vacía");
            return; // Termina la ejecución del método si la lista está vacía.
        }

        foreach (var i in ListContents)
        {
            Console.WriteLine("entre al foreach");
            {
                if (i.Type == "Gun")
                {
                    _destination.ListGuns.Add(i);
                }
                else
                {
                    _destination.ListMedicines.Add(i);
                    Console.WriteLine("entre al else");
                }
                
            }
        }

    }
}

