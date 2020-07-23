// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Play.Review
{
    /// <summary>
    /// Errors that can be encountered while requesting the in-app review dialog.
    /// </summary>
    public enum ReviewErrorCode
    {
        /// <summary>
        /// No error has occurred.
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Error while requesting in-app review flow.
        /// </summary>
        ErrorRequestingFlow = 1,

        /// <summary>
        /// Error while launching in-app review flow.
        /// </summary>
        ErrorLaunchingFlow = 2,
    }
}
