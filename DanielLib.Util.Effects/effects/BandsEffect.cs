﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace Daniellib.Util.Effects
{
	
	/// <summary>An effect that creates bands of bright regions.</summary>
	public class BandsEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(BandsEffect), 0);
		public static readonly DependencyProperty BandDensityProperty = DependencyProperty.Register("BandDensity", typeof(double), typeof(BandsEffect), new UIPropertyMetadata(((double)(65D)), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty BandIntensityProperty = DependencyProperty.Register("BandIntensity", typeof(double), typeof(BandsEffect), new UIPropertyMetadata(((double)(0.056D)), PixelShaderConstantCallback(1)));
		public BandsEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Daniellib.Util.Effects;component/effects/ps/Bands.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(BandDensityProperty);
			this.UpdateShaderValue(BandIntensityProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The number of verical bands to add to the output. The higher the value the more bands.</summary>
		public double BandDensity {
			get {
				return ((double)(this.GetValue(BandDensityProperty)));
			}
			set {
				this.SetValue(BandDensityProperty, value);
			}
		}
		/// <summary>Intensity of each band.</summary>
		public double BandIntensity {
			get {
				return ((double)(this.GetValue(BandIntensityProperty)));
			}
			set {
				this.SetValue(BandIntensityProperty, value);
			}
		}
	}
}