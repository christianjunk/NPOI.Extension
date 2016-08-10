#region Copyright (c) 2016, Amec Foster Wheeler E&I GmbH
// All rights reserved.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
// POSSIBILITY OF SUCH DAMAGE.
// 
// REPRODUCTION OR TRANSMISSION IN WHOLE OR IN PART, ANY FORM OR BY ANY 
// MEANS, ELECTRONIC, MECHANICAL OR OTHERWISE, IS PROHIBITED WITHOUT THE PRIOR 
// WRITTEN CONSENT OF THE COPYRIGHT OWNER.
#endregion

namespace NPOI.Extension.Tests.Case_2
{
    public class HazmatStorageLocationArea : IStorageLocationArea
    {
        [Column(AutoIndex = true, Title = "facilityNumber")]
        public string facilityNumber { get; set; }
        [Column(AutoIndex = true, Title = "installationID")]
        public string installationID { get; set; }
        [Column(AutoIndex = true, Title = "sdsID")]
        public string sdsID { get; set; }
        [Column(AutoIndex = true, Title = "LOC_ID")]
        public string locationID { get; set; }
        [Column(AutoIndex = true, Title = "UNIT")]
        public string unit { get; set; }
        [Column(AutoIndex = true, Title = "FLOOR")]
        public string floor { get; set; }
        [Column(AutoIndex = true, Title = "LOC_DESC")]
        public string locationDescription { get; set; }
        [Column(AutoIndex = true, Title = "MAT_DESC")]
        public string materialDescription { get; set; }
        [Column(AutoIndex = true, Title = "COMMENT")]
        public string comment { get; set; }
        [Column(AutoIndex = true, Title = "PHOTO_ID")]
        public string photoID { get; set; }
    }
}