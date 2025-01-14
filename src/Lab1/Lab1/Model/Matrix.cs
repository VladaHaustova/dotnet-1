﻿using System.Xml;

namespace Lab1.Model
{
    public abstract class Matrix
    {
        public abstract int GetMatrixSize();
        public abstract double GetValueByIndex(int i, int j);
        public abstract void SetValueByIndex(int i, int j, double value);
        public abstract void PrintMatrix();
        public abstract override string ToString();
        public abstract override int GetHashCode();
        public abstract double GetMaxElm();
        public abstract double GetMaxElmLinq();

        public abstract void ToXml(XmlTextWriter writer);
        public abstract void LoadXml(XmlTextReader reader);
    }
}