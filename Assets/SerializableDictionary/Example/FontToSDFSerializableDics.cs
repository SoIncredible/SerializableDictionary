using System;
using UnityEngine;

[Serializable]
public class FontStringArrayDictionary : SerializableDictionary<Font, string[], StringArrayStorage>
{
}

[Serializable]
public class StringArrayStorage : SerializableDictionary.Storage<string[]>
{
}