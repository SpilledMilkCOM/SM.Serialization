using System;
using System.IO;

namespace SM.Serialization
{
	/// <summary>
	/// An interface for typical serialization operations.
	/// </summary>
	public interface ISerializationUtility
	{
		/// <summary>
		/// Deserialize the JSON data to the type given.
		/// </summary>
		/// <typeparam name="TType">Desired object type.</typeparam>
		/// <param name="jsonData">The JSON data.</param>
		/// <returns>Desired object from the data.</returns>
		TType Deserialize<TType>(string jsonData);

		object Deserialize(string jsonData, Type type);

		object Deserialize(TextReader streamReader, Type type);

		TType Deserialize<TType>(TextReader streamReader);

		string Serialize(object obj);

		void Serialize(StreamWriter streamWriter, object obj);
	}
}