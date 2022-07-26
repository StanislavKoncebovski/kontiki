/***********************************************************************************
* File:         QueryColumn.cs                                                     *
* Contents:     Enum QueryColumn                                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-07-26 14:15                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Kontiki
{
	/// <summary>
	/// Defines the search column of a LibGen request.
	/// </summary>
	public enum QueryColumn
	{
		Default,	// = column=def
		Author,		// = column=author
		Title,		// = column=title
		ISBN,		// = column=identifier
		Tags		// = column=tags
	}
}
