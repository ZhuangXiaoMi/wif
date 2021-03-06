﻿using Frontier.Wif.Core.ComponentModel;

namespace Wif.Demo.Common
{
    /// <summary>
    /// Defines the <see cref="MobilePhone" />
    /// </summary>
    public class MobilePhone : PropertyChangedBase
    {
        #region Fields

        /// <summary>
        /// Defines the _brand
        /// </summary>
        private Brand _brand;

        /// <summary>
        /// Defines the _NumberOfCPUCore
        /// </summary>
        private NumberOfCPUCore _NumberOfCPUCore;

        /// <summary>
        /// Defines the _RAM
        /// </summary>
        private RAM _RAM;

        /// <summary>
        /// Defines the _ROM
        /// </summary>
        private ROM _ROM;

        /// <summary>
        /// Defines the _ScreenResolution
        /// </summary>
        private ScreenResolution _ScreenResolution;

        /// <summary>
        /// Defines the _screenSize
        /// </summary>
        private int _screenSize;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Brand
        /// </summary>
        public Brand Brand
        {
            get => _brand;
            set => RaiseAndSetIfChanged(ref _brand, value);
        }

        /// <summary>
        /// Gets or sets the NumberOfCPUCore
        /// </summary>
        public NumberOfCPUCore NumberOfCPUCore
        {
            get => _NumberOfCPUCore;
            set => RaiseAndSetIfChanged(ref _NumberOfCPUCore, value);
        }

        /// <summary>
        /// Gets or sets the RAM
        /// </summary>
        public RAM RAM
        {
            get => _RAM;
            set => RaiseAndSetIfChanged(ref _RAM, value);
        }

        /// <summary>
        /// Gets or sets the ROM
        /// </summary>
        public ROM ROM
        {
            get => _ROM;
            set => RaiseAndSetIfChanged(ref _ROM, value);
        }

        /// <summary>
        /// Gets or sets the ScreenResolution
        /// </summary>
        public ScreenResolution ScreenResolution
        {
            get => _ScreenResolution;
            set => RaiseAndSetIfChanged(ref _ScreenResolution, value);
        }

        /// <summary>
        /// Gets or sets the ScreenSize
        /// </summary>
        public int ScreenSize
        {
            get => _screenSize;
            set => RaiseAndSetIfChanged(ref _screenSize, value);
        }

        #endregion
    }
}