NDSummary.OnToolTipsLoaded("CClass:NodeDiscovery",{1045:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype1045\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">NodeDiscovery</div></div></div><div class=\"TTSummary\">Represents 1 node discovery, which is created when a Wireless Node Discovery packet is sent from a Node.&nbsp; Note: There are multiple versions of Node Discovery packets which have been developed over time.&nbsp; Each version has added more useful information. If an earlier version of the Node Discovery packet is heard, this NodeDiscovery object will have some information be invalid (set to default values).</div></div>",1046:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1046\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">uint16</span> nodeAddress() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the node address of the discovered Node.</div></div>",1047:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1047\" class=\"NDPrototype NoParameterForm\">WirelessTypes::Frequency frequency() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the WirelessTypes::Frequency of the discovered Node.</div></div>",1048:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1048\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">uint16</span> panId() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the PAN Id of the discovered Node.&nbsp; Note: Returns 0 if not present in the packet.</div></div>",1049:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1049\" class=\"NDPrototype NoParameterForm\">WirelessModels::NodeModel model() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the model of the discovered Node.</div></div>",1050:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1050\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">uint32</span> serialNumber() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the serial number of the discovered Node.&nbsp; Note: Returns 0 if not present in the packet.</div></div>",1051:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1051\" class=\"NDPrototype NoParameterForm\">Version firmwareVersion() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the firmware version of the discovered Node.&nbsp; Note: Returns 0.0.0 if not present in the packet.</div></div>",1052:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1052\" class=\"NDPrototype NoParameterForm\">WirelessTypes::DefaultMode defaultMode()</div><div class=\"TTSummary\">Gets the WirelessTypes::DefaultMode of the discovered Node.&nbsp; Note: Returns 999 if not present in the packet.</div></div>",1053:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1053\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">int16</span> baseRssi() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the base station rssi of the discovered Node.</div></div>",1054:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1054\" class=\"NDPrototype NoParameterForm\">Timestamp timestamp() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the Timestamp of when the NodeDiscovery packet was received by MSCL.</div></div>",1055:"<div class=\"NDToolTip TType LC\"><div class=\"TTSummary\">typedef for a vector of NodeDiscovery objects</div></div>"});