NDContentPage.OnToolTipsLoaded({2:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype2\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">UnixSocketConnection</div></div></div><div class=\"TTSummary\">A Connection_Impl derived class that represents a unix socket connection.</div></div>",8:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype8\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">TcpIpConnection</div></div></div><div class=\"TTSummary\">A Connection_Impl derived class that represents a tcp/ip connection.</div></div>",16:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype16\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">SerialConnection</div></div></div><div class=\"TTSummary\">A Connection_Impl derived class that represents a serial connection.</div></div>",63:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype63\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Connection_Impl_Base</div></div></div><div class=\"TTSummary\">An Abstract Base Class for various connection types.</div></div>",78:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype78\"><div class=\"CPEntry TClass Current\"><div class=\"CPModifiers\"><span class=\"SHKeyword\">template</span> &lt;typename Comm_Object&gt;</div><div class=\"CPName\">Connection_Impl</div></div></div><div class=\"TTSummary\">An Abstract Base Class for various connection types.&nbsp; This class uses a template for the Comm Object and contains default functionality for connection types.</div></div>",111:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype111\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Connection</div></div></div><div class=\"TTSummary\">The Connection object that is used for communication.</div></div>",113:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype113\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\">Connection(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\">std::</td><td class=\"PType\">shared_ptr&lt;Connection_Impl_Base&gt;&nbsp;</td><td class=\"PName last\">impl</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Creates a Connection object with the given implementation.&nbsp; Note: This constructor should not be used in most cases.&nbsp; Please use the static Serial, TcpIp, and UnixSocket functions.</div></div>",114:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype114\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">static</span> Connection Serial(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span> std::</td><td class=\"PType\"><span class=\"SHKeyword\">string</span>&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName\">port,</td><td></td><td class=\"last\"></td></tr><tr><td class=\"first\"></td><td class=\"PType\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td></td><td class=\"PName\">baudRate&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHNumber\">921600</span></td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">A static function for creating a Connection object with a SerialConnection implementation.&nbsp; A connection with the specified port will be established.</div></div>",115:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype115\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">static</span> Connection TcpIp(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span> std::</td><td class=\"PType\"><span class=\"SHKeyword\">string</span>&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">serverAddress,</td></tr><tr><td class=\"first\"></td><td class=\"PType\"><span class=\"SHKeyword\">uint16</span>&nbsp;</td><td></td><td class=\"PName last\">serverPort</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">A static function for creating a Connection object with a TcpIpConnection implementation.&nbsp; A connection with the specified address/port will be established.</div></div>",116:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype116\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">static</span> Connection UnixSocket(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span> std::</td><td class=\"PType\"><span class=\"SHKeyword\">string</span>&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">path</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">A generator function for Connection objects with a UnixSocketConnection implementation (Unix builds only).&nbsp; A connection with the specified path will be established.</div></div>",130:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype130\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">void</span> rawByteMode(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">enable</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Puts the connection into &quot;Raw Byte Mode.&quot;  &quot;Raw Byte Mode&quot; stops the data from being sent/parsed from any attached devices (BaseStation, InertialNode, etc.)&nbsp; and instead sends all data into a raw circular data buffer that can be accessed by calling getRawBytes on this Connection object.&nbsp; Disabling this mode will start sending all data back to the previous attached device, if still available.</div></div>",131:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype131\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\">Bytes getRawBytes(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td class=\"PName\">timeout&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHNumber\">0</span>,</td></tr><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td class=\"PName\">maxBytes&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHNumber\">0</span></td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Gets the raw bytes that are available that have been collected when the Connection is in &quot;Raw Byte Mode.&quot;&nbsp; If the Connection has not been put into &quot;Raw Byte Mode&quot; by calling rawByteMode, no data can be retrieved from this function.</div></div>",3809:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype3809\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">DataBuffer</div></div></div><div class=\"TTSummary\">A buffer of bytes extending from the ByteStream class that is used for holding bytes read in from the connection</div></div>",3858:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype3858\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">ByteStream</div></div></div><div class=\"TTSummary\">A stream of bytes that is used to easily store and retrieve data</div></div>",4023:"<div class=\"NDToolTip TType LC\"><div class=\"TTSummary\">typedef for a vector of bytes.</div></div>",4159:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype4159\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Error_Connection</div></div></div><div class=\"TTSummary\">The generic connection exception.</div></div>",4168:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype4168\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Error_InvalidSerialPort</div></div></div><div class=\"TTSummary\">There was an error with the specified COM Port.</div></div>",4171:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype4171\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Error_InvalidTcpServer</div></div></div><div class=\"TTSummary\">There was an error with the specified TCP/IP Server.</div></div>",4174:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype4174\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Error_InvalidUnixSocket</div></div></div><div class=\"TTSummary\">There was an error with the specified Unix Socket.</div></div>"});