//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GoogleARCore;
using GoogleARCoreInternal;
using UnityEngine;

/// <summary>
/// Uses 4 frame corner objects to visualize an AugmentedImage.
/// </summary>
public class ARCoreImageVisualizer : MonoBehaviour
{
    /// <summary>
    /// The AugmentedImage to visualize.
    /// </summary>
    public AugmentedImage Image;

    /// <summary>
    /// A model to be placed on object
    /// </summary>
    public GameObject Cube;


    /// <summary>
    /// The Unity Update method.
    /// </summary>
    public void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            Cube.SetActive(false);
            return;
        }

        float halfWidth = Image.ExtentX / 2;
        float halfHeight = Image.ExtentZ / 2;
        Cube.transform.localPosition = (halfWidth * Vector3.zero) + (halfHeight * Vector3.zero);
        Cube.SetActive(true);
    }
}