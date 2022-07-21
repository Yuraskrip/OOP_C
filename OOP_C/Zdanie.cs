namespace OOP_C
{
    public class Zdanie
    {
        private int _Number;
        private int _Height;
        private int _Floor;
        private int _Flat;
        private int _Entrance;

		public enum Dom 
		{ 
			Number,
			Height, 
			Floor, 
			Flat, 
			Entrance
		}

		internal Zdanie(int height, int floor, int flat, int entrance)
		{
			(_Height, _Floor, _Flat, _Entrance) = (height, floor, flat, entrance);
			_Number = GenerateNumber();
		}

		private static int _LastNumber; // статическое поле для хранения последнего использованного номера здания,

		/// <summary>
		/// Чтение значения полей
		/// </summary>
		/// <param name="dom"></param>
		/// <returns></returns>
		public int Get(Dom dom)
		{
			switch (dom)
			{
				case Dom.Number:
					return _Number;
					break;
				case Dom.Height:
					return _Height;
					break;
				case Dom.Floor:
					return _Floor;
					break;
				case Dom.Flat:
					return _Flat;
					break;
				case Dom.Entrance:
					return _Entrance;
					break;
				default:
					return 0;
					break;
			}
		}

		/// <summary>
		/// Заполнение полей
		/// </summary>
		/// <param name="dom"></param>
		/// <param name="value"></param>
		internal void Set(Dom dom, int value)
		{
			switch (dom)
			{
				case Dom.Number:
					_Number = value;
					break;
				case Dom.Height:
					_Height = value;
					break;
				case Dom.Floor:
					_Floor = value;
					break;
				case Dom.Flat:
					_Flat = value;
					break;
				case Dom.Entrance:
					_Entrance = value;
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Вычисление высоты этажа
		/// </summary>
		/// <returns></returns>
		public int UFloorHeight()
		{
			return _Height / _Floor;
		}

		/// <summary>
		/// Вычисление количества квартир в подъезде
		/// </summary>
		/// <returns></returns>
		public int FlatsIn1Entr()
		{
			return _Flat / _Entrance;
		}

		/// <summary>
		/// Вычисление количества квартир на этаже
		/// </summary>
		/// <returns></returns>
		public int FltsIn1Floor()
		{
			return _Flat / _Floor;
		}

		/// <summary>
		/// Уникальный номер здания, увеличивающий значение поля
		/// </summary>
		/// <returns></returns>
		private int GenerateNumber()
		{
			_LastNumber += 1;
			return _LastNumber;
		}

	}

}
