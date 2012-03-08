﻿/*
 * Copyright (C) 2009-2012 - Zelimir Fedoran
 *
 * This file is part of Bubble Bound.
 *
 * Bubble Bound is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Bubble Bound is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Bubble Bound.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hyades.physics
{
    public class Bitmask
    {
        public int mask;

        public void clear() { mask = 0x00; }
        public void setOn(int bit)
        {
            mask |= (0x01 << ((bit > 0) ? (bit - 1) : 0));
        }
        public void setOff(int bit)
        {
            mask &= ~(0x01 << ((bit > 0) ? (bit - 1) : 0));
        }
    }
}
