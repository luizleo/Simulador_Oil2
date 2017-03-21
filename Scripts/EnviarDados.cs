using UnityEngine;
using System.Collections;
using System;

//   Script que recolhe os dados dos botões do controlador unity, e envia para os simuladores a serem controlados - Luiz Felipe Léo - 10/10/2016



public class EnviarDados : MonoBehaviour {
	public string[] dados = new string[88];
	public string[] dadosOceano = new string[30];



	void Start () {
		
		// Valores Iniciais do UniStorm e Ceto
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\clima_padrao.txt"); // Local onde os valores padrões são guardados
		while(((line = file.ReadLine()) != null) && (indice < 88))
		{
			dados [indice] = line;
			indice++;

		}

		file.Close();

		indice = 0;

		 file = new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\oceano_padrao.txt");
		while(((line = file.ReadLine()) != null) && (indice < 30))
		{
			dadosOceano [indice] = line;
			indice++;

		}

		file.Close();

	

	}



	// Update is called once per frame
	void Update () {
//		System.IO.File.WriteAllLines (@"C:\Users\Visualizador04\LabOceano - Luiz Tarefas\ultimo_clima.txt",dados);  // Pc de teste
//		System.IO.File.WriteAllLines (@"C:\Users\Visualizador04\LabOceano - Luiz Tarefas\ultimo_oceano.txt",dadosOceano);
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\ultimo_clima.txt",dados);    // Localização do arquivo final onde todos os visualizadores irão consultar
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\ultimo_oceano.txt",dadosOceano);
	}
	// #################################################### UniStorm Script #############################################################################################
	// #################################################### UniStorm Script #############################################################################################
	// #################################################### UniStorm Script #############################################################################################
	//Funções pertencentes ao UniStorm Script
	public void cloudDensity_change (string valor)
	{
		dados[0] = valor;
	}
	public void cloudHeight_change (string valor)
	{
		dados[1] = valor;
	}
	public void Fade_change (string valor)
	{
		dados[2] = valor;
	}
	public void Speed_change (string valor)
	{
		dados[3] = valor;
	}
	public void Storm_change (string valor)
	{
		dados[4] = valor;
	}
	public void StarScroll_change (string valor)
	{
		dados[5] = valor;
	}
	public void StarSpeed_change (string valor)
	{
		dados[6] = valor;
	}
	public void weatherForecaster_change (Int32 valor)
	{
		dados[7] = string.Format("{0:f0}",valor);
	}
	public void staticWeather_change (bool valor)
	{
		dados[8] = string.Format("{0:f0}",valor);
	}
	public void useInstantStartingWeather_change (bool valor)
	{
		dados[9] = string.Format("{0:f0}",valor);
	}
	public void precipitationOddsSpring_change (float valor)
	{
		dados[10] = string.Format("{0:f0}",valor);
	}
	public void precipitationOddsFall_change (float valor)
	{
		dados[11] = string.Format("{0:f0}",valor);
	}
	public void precipitationOddsSummer_change (float valor)
	{
		dados[12] = string.Format("{0:f0}",valor);
	}
	public void precipitationOddsWinter_change (float valor)
	{
		dados[13] = string.Format("{0:f0}",valor);
	}



	public void slider_RegularCloudIn_change (string valor)
	{
		dados[14] = valor;
	}
	public void slider_RegularCLoudOut_change (string valor)
	{
		dados[15] = valor;
	}
	public void slider_StormCloudIn_change (string valor)
	{
		dados[16] = valor;
	}
	public void slider_StormCloudOut_change (string valor)
	{
		dados[17] = valor;
	}
	public void slider_ParticleEffectsIn_change (string valor)
	{
		dados[18] = valor;
	}
	public void slider_ParticlesEffectsOut_change (string valor)
	{
		dados[19] = valor;
	}
	public void slider_SoundIn_change (string valor)
	{
		dados[20] = valor;
	}
	public void slider_SoundOut_change (string valor)
	{
		dados[21] = valor;
	}
	public void slider_FogDistanceIn_change (string valor)
	{
		dados[22] = valor;
	}
	public void slider_FogDistanceOut_change (string valor)
	{
		dados[23] = valor;
	}
	public void slider_FogColorIn_change (string valor)
	{
		dados[24] = valor;
	}
	public void slider_FogColorOut_change (string valor)
	{
		dados[25] = valor;
	}

	public void slider_WindIn_change (string valor)
	{
		dados[26] = valor;
	}
	public void slider_WindOut_change (string valor)
	{
		dados[27] = valor;
	}
	public void slider_SunIntensity_change (string valor)
	{
		dados[28] = valor;
	}
	public void slider_SunSize_change (string valor)
	{
		dados[29] = valor;
	}
	public void slider_CloudSunIntensity_change (string valor)
	{
		dados[30] = valor;
	}
	public void ShadowEnable_change (bool valor)
	{
		dados[31] = string.Format("{0:f0}",valor);
	}
	public void ShadowType_change (Int32 valor)
	{
		dados[32] = string.Format("{0:f0}",valor+1);

	}
	public void ShadowIntensity_change(string valor)
	{
		dados [33] = valor;
	}
	public void SunHeight_change(string valor)
	{
		dados[34] = valor;
	}
	public void SunRotation_change(string valor)
	{
		dados[35] = valor;
	}
	public void AmbienteIntensity_change (Int32 valor)
	{
		dados[36] = string.Format("{0:f0}",valor+1);
	}

	public void TwilightAmbient_change(string valor)
	{
		dados[37] = valor;
	}
	public void MorningAmbient_change(string valor)
	{
		dados[38] = valor;
	}
	public void DayAmbient_change(string valor)
	{
		dados[39] = valor;
	}
	public void EveningAmbient_change(string valor)
	{
		dados[40] = valor;
	}
	public void NightAmbient_change(string valor)
	{
		dados[41] = valor;
	}
	public void RandomizePrecipitation_change (bool valor)
	{
		dados[42] = string.Format("{0:f0}",valor);
	}
	public void UseRainStreaks_change (bool valor)
	{
		dados[43] = string.Format("{0:f0}",valor);
	}
	public void UseRainMist_change (bool valor)
	{
		dados[44] = string.Format("{0:f0}",valor);
	}
	public void UseRainSplashes_change (bool valor)
	{
		dados[45] = string.Format("{0:f0}",valor);
	}
	public void PrecipitaitonControl_change (bool valor)
	{
		dados[46] = string.Format("{0:f0}",valor);

	}
	public void ChangeWeatherDays_change (string valor)
	{
		dados[47] = valor;
	}
	public void lightRain_change (string valor)
	{
		dados[48] = valor;
	}
	public void LightRainmist_change (string valor)
	{
		dados[49] = valor;
	}
	public void HeavyRain_change (string valor)
	{
		dados[50] = valor;
	}
	public void HeavyRainSteaks_change (string valor)
	{
		dados[51] = valor;
	}
	public void HeavyRainMist_change (string valor)
	{
		dados[52] = valor;
	}
	public void LightSnow_change (string valor)
	{
		dados[53] = valor;
	}
	public void LightSnowDust_change (string valor)
	{
		dados[54] = valor;
	}
	public void HeavySnow_change (string valor)
	{
		dados[55] = valor;
	}
	public void HeavySnowDust_change (string valor)
	{
		dados[56] = valor;
	}
	public void UseCustomSounds_change (bool valor)
	{
		dados[57] = string.Format("{0:f0}",valor);
	}
	public void startTimeHour_change (Int32 valor)
	{
		dados[58] = string.Format("{0:f0}",valor);
	}
	public void startTimeMinute_change (float valor)
	{
		dados[59] = string.Format("{0:f0}",valor);
	}
	public void minuteCounter_change (string valor)
	{
		dados[60] = valor;

	}
	public void HourCounter_change (string valor)
	{
		dados[61] = valor;
	}
	public void dayCounter_change(string valor)
	{
		dados[62] = valor;
	}
	public void monthCounter_change (Int32 valor)
	{
		dados[63] = string.Format("{0:f0}",valor+1);
	}
	public void yearCounter_change (string valor)
	{
		dados[64] = valor;
	}
	public void dayLengthHour_change (Int32 valor)
	{
		dados [65] = string.Format ("{0:f0}", valor);
	}
	public void dayLength_change (string valor)
	{
		dados[66] = valor;
	}
	public void nightLengthHour_change (Int32 valor)
	{
		dados [67] = string.Format ("{0:f0}", valor);
	}
	public void nightLength_change (string valor)
	{
		dados[68] = valor;
	}
	public void timeStopped_change (bool valor)
	{
		dados [69] = string.Format ("{0:f0}", valor);
	}
	public void AutoEnableFog_change (bool valor)
	{
		dados [70] = string.Format ("{0:f0}", valor);
	}
	public void fogMode_change (Int32 valor)
	{
		dados [71] = string.Format ("{0:f0}", valor);
	}
	public void StormFogStart_change (float valor)
	{
		dados [72] = string.Format ("{0:f0}", valor);
	}
	public void StormFogEnd_change (float valor)
	{
		dados [73] = string.Format ("{0:f0}", valor);
	}
	public void RegularFogStart_change (float valor)
	{
		dados [74] = string.Format ("{0:f0}", valor);
	}
	public void RegularFogEnd_change (float valor)
	{
		dados [75] = string.Format ("{0:f0}", valor);
	}
	public void FogDensity_change (float valor)
	{
		dados [76] = string.Format ("{0:f3}", valor);
	}
	public void DisableTemperature_change (bool valor)
	{
		dados [77] = string.Format ("{0:f0}", valor);
	}
	public void temperatureType_change (Int32 valor)
	{
		dados [78] = string.Format ("{0:f0}", valor+1);
	}
	public void temperature_change (string valor)
	{
		dados[79] = valor;
	}
	public void moonIntensity_change (float valor)
	{
		dados [80] = string.Format ("{0:f0}", valor);
	}
	public void moonShadowEnable_change (bool valor)
	{
		dados [81] = string.Format ("{0:f0}", valor);
	}
	public void moonShadowType_change (Int32 valor)
	{
		dados [82] = string.Format ("{0:f0}", valor+1);
	}
	public void moonShadowIntensity (float valor)
	{
		dados [83] = string.Format ("{0:f2}", valor);
	}
	public void useLightShafs_change (bool valor)
	{
		dados [84] = string.Format ("{0:f0}", valor);
	}
	public void customMoonSize_change (bool valor)
	{
		dados [85] = string.Format ("{0:f0}", valor);
	}
	public void moonSize_change (float valor)
	{
		dados [86] = string.Format ("{0:f0}", valor);
	}
	public void moonPhase_change (Int32 valor)
	{
		dados [87] = string.Format ("{0:f0}", valor+1);
	}
	// #################################################### Ocean Script (ceto)#############################################################################################
	// #################################################### Ocean Script (ceto)#############################################################################################
	// #################################################### Ocean Script (ceto)#############################################################################################
	// Funções pertencentes ao Ocean Script do Ceto
	public void level_change (string valor)
	{
		dadosOceano[0] = valor;
	}

	public void windDir_change (float valor)
	{
		dadosOceano [1] = string.Format ("{0:f2}", valor);
	}

	public void specularRough_change (float valor)
	{
		dadosOceano [2] = string.Format ("{0:f2}", valor);
	}
	public void specularIntensity_change (float valor)
	{
		dadosOceano [3] = string.Format ("{0:f2}", valor);
	}
	public void fresnelPower_change (float valor)
	{
		dadosOceano [4] = string.Format ("{0:f2}", valor);
	}
	public void minFresnel_change (float valor)
	{
		dadosOceano [5] = string.Format ("{0:f2}", valor);
	}
	public void foamIntensity_change (float valor)
	{
		dadosOceano [6] = string.Format ("{0:f2}", valor);
	}
	// #################################################### ProjectedGrid Script #############################################################################################
	// #################################################### ProjectedGrid Script #############################################################################################
	// #################################################### ProjectedGrid Script #############################################################################################
	//Funções pertencentes ao ProjectedGrid Script do Ceto
	public void change_resolution (Int32 valor)
	{
		dadosOceano [7] = string.Format ("{0:f0}", valor);
	}

	public void receiveshadows_change (bool valor)
	{
		dadosOceano [8] = string.Format ("{0:f0}", valor);
	}

	// #################################################### WaveSpectrum Script (ceto)#############################################################################################
	// #################################################### WaveSpectrum Script (ceto)#############################################################################################
	// #################################################### WaveSpectrum Script(ceto) #############################################################################################
	//Funções pertencentes ao WaveSpectrum Script do Ceto

	public void fourierSize_change (Int32 valor)
	{

		dadosOceano [9] = string.Format ("{0:f0}", valor);
	}
	public void spectruimType_change (Int32 valor)
	{
		dadosOceano [10] = string.Format ("{0:f0}", valor);
	}
	public void numberOfGrids_change (float valor)
	{
		dadosOceano [11] = string.Format ("{0:f0}", valor);
	}
	public void disableReadBlack_change (bool valor)
	{
		dadosOceano [12] = string.Format ("{0:f0}", valor);
	}
	public void disableSlopes_change (bool valor)
	{
		dadosOceano [13] = string.Format ("{0:f0}", valor);
	}
	public void disableFoam_change (bool valor)
	{
		dadosOceano [14] = string.Format ("{0:f0}", valor);
	}
	public void textureFoam_change (bool valor)
	{
		dadosOceano [15] = string.Format ("{0:f0}", valor);
	}
	public void DisableDisplacementes_change (bool valor)
	{
		dadosOceano [16] = string.Format ("{0:f0}", valor);
	}
	public void chop_change (float valor)
	{
		dadosOceano [17] = string.Format ("{0:f2}", valor);
	}
	public void foamAmount_change (float valor)
	{
		dadosOceano [18] = string.Format ("{0:f2}", valor);
	}
	public void foamCoverage_change (float valor)
	{
		dadosOceano [19] = string.Format ("{0:f2}", valor);
	}
	public void windSpeed_change (float valor)
	{
		dadosOceano [20] = string.Format ("{0:f2}", valor);
	}
	public void waveAge_change (float valor)
	{
		dadosOceano [21] = string.Format ("{0:f2}", valor);
	}
	public void waveSpeed_change (float valor)
	{
		dadosOceano [22] = string.Format ("{0:f2}", valor);
	}
	public void gridScale_change(float valor)
	{
		dadosOceano [23] = string.Format ("{0:f2}", valor);
	}
	public void waveSmoothing_change (float valor)
	{
		dadosOceano [24] = string.Format ("{0:f2}", valor);
	}
	// #################################################### PlanarReflection Script (ceto)#############################################################################################
	// #################################################### PlanarReflection Script (ceto)#############################################################################################
	// #################################################### PlanarReflection Script (ceto)#############################################################################################
	//Funções pertencentes ao PlanarReflection Script do Ceto
	public void skyboxreflection_change (bool valor)
	{
		dadosOceano [25] = string.Format ("{0:f0}", valor);
	}
	public void fogreflection_change (bool valor)
	{
		dadosOceano [26] = string.Format ("{0:f0}", valor);
	}
	public void blurInterations_change (float valor)
	{
		dadosOceano [27] = string.Format ("{0:f0}", valor);
	}
	public void reflectionIntensity_change (float valor)
	{
		dadosOceano [28] = string.Format ("{0:f2}", valor);
	}
	public void reflectionDistortion_change (float valor)
	{
		dadosOceano [29] = string.Format ("{0:f2}", valor);
	}


	// Funções de Load e Save de configurações pré-definidas pelo usuário
	public void guardarAtual1 ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\clima_backup1.txt",dados); // Guarda o clima atual no clima pré-definido 1 2 ou 3 no local indicado
	}

	public void guardarAtual2 ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\clima_backup2.txt",dados);
	}
	public void guardarAtual3()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\clima_backup3.txt",dados);
	}
	public void carregarAtual1()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\clima_backup1.txt"); // Carrega os climas pré-definidos 1 2 ou 3 de acordo com o local indicado
		while((line = file.ReadLine()) != null)
		{
			dados [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregarAtual2()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\clima_backup2.txt");
		while((line = file.ReadLine()) != null)
		{
			dados [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregarAtual3()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\clima_backup3.txt");
		while((line = file.ReadLine()) != null)
		{
			dados [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregardefault()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\clima_padrao.txt"); // Volta o clima para o padrão inicial do simulador
		while((line = file.ReadLine()) != null)
		{
			dados [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void atualtodefault ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\clima_padrao.txt",dados); // Salva o clima atual como o clima padrão do simulador
	}

	public void guardarOceanoAtual1 ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\oceano_backup1.txt",dadosOceano); // Guarda o oceano atual como oceano salvo 1 2 ou 3 de acordo com o local indicado
	}

	public void guardaroceanoAtual2 ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\oceano_backup2.txt",dadosOceano);
	}
	public void guardaroceanoAtual3()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\oceano_backup3.txt",dadosOceano);
	}
	public void carregarOceanoAtual1()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\oceano_backup1.txt"); // Carrega os oceanos pré definidos 1 2 ou 3
		while((line = file.ReadLine()) != null)
		{
			dadosOceano [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregarOceanoAtual2()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\oceano_backup2.txt");
		while((line = file.ReadLine()) != null)
		{
			dadosOceano [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregarOceanoAtual3()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\oceano_backup3.txt");
		while((line = file.ReadLine()) != null)
		{
			dadosOceano [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void carregaroceanodefault()
	{
		int indice = 0;
		string line;
		System.IO.StreamReader file = 
			new System.IO.StreamReader(@"\\LABOSIM-2-DELL2\server\oceano_padrao.txt"); // Carrega o oceano padrão do simulador
		while((line = file.ReadLine()) != null)
		{
			dadosOceano [indice] = line;
			indice++;

		}

		file.Close();
	}
	public void oceanoatualtodefault ()
	{
		System.IO.File.WriteAllLines (@"\\LABOSIM-2-DELL2\server\oceano_padrao.txt",dadosOceano); // Salva o oceano atual como oceano padrão do simulador
	}



}
