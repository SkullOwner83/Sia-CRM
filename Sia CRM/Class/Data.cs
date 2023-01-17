using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace SiaCRM
{
	public class Data
	{
		//Validate only numeric inputs by his ASCII code range
		public static bool OnlyNumeric(char KeyChar)
		{ 
			if ((KeyChar >= 32 && KeyChar <= 47) || (KeyChar >= 58 && KeyChar <= 255))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		//Validate only alphabet inputs by his ASCII code range
		public static bool OnlyAlphabet(char KeyChar)
		{ 
			if ((KeyChar >= 33 && KeyChar <= 64) || (KeyChar >= 91 && KeyChar <= 96) || (KeyChar >= 123 && KeyChar <= 255))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//Encrypt input data through byte string
		public static string Encrypt(string Message)
		{
			string Result = string.Empty;
			byte[] MsgEncrypted = System.Text.Encoding.Unicode.GetBytes(Message);
			Result = Convert.ToBase64String(MsgEncrypted);
			return Result;
		}

		//Decrypt input data encrypted previous
		public static string Decrypt(string Message)
		{
			string Result = string.Empty;
			byte[] MsgDecrypt = Convert.FromBase64String(Message);
			Result = System.Text.Encoding.Unicode.GetString(MsgDecrypt);
			return Result;
		}

		//Encrypt input data through hash
		public static string EncryptMD5(string Message)
		{
			string Hash = "EncryptedCoding";
			byte[] data = UTF8Encoding.UTF8.GetBytes(Message);
			
			MD5 md5 = MD5.Create();
			TripleDES TripleDes = TripleDES.Create();

			TripleDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
			TripleDes.Mode = CipherMode.ECB;

			ICryptoTransform transform = TripleDes.CreateEncryptor();
			byte[] Result = transform.TransformFinalBlock(data, 0, data.Length);

			return Convert.ToBase64String(Result);
		}

		//Decrypt input data encrypted previous
		public static string DecryptMD5(string Message)
		{
			string Hash = "EncryptedCoding";
			byte[] data = Convert.FromBase64String(Message);
			
			MD5 md5 = MD5.Create();
			TripleDES TripleDes = TripleDES.Create();

			TripleDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
			TripleDes.Mode = CipherMode.ECB;

			ICryptoTransform transform = TripleDes.CreateDecryptor();
			byte[] Result = transform.TransformFinalBlock(data, 0, data.Length);

			return UTF8Encoding.UTF8.GetString(Result);
		}
	}
}
