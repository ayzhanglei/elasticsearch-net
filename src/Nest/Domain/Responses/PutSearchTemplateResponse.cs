﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest
{
	public interface IPutSearchTemplateResponse : IResponse
	{

	}

	public class PutSearchTemplateResponse : BaseResponse, IPutSearchTemplateResponse
	{
	}
}
