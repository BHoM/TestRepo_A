/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */


using BH.oM.Base.Attributes;
using BH.oM.TestA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BH.Engine.TestA
{
    public static partial class Modify
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        [Description("Description of the method. Will appear in the UI tooltip.")]
        [Input("objectToModify", "Description of the input. Will appear in the UI tooltip.")]
        [Input("additionalInput", "Description of the input. Will appear in the UI tooltip.")]
        public static ExampleObjectA ExampleModifyMethod(ExampleObjectA objectToModify)
        {
            // This method will appear in every UI (e.g. Grasshopper) as a component.
            // Find it using the CTRL+Shift+B search bar, or by navigating the `Create` component (Engine tab) right click menu.
            throw new NotImplementedException();
        }

        /***************************************************/

    }
}


