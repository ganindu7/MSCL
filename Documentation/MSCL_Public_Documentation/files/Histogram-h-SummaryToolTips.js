NDSummary.OnToolTipsLoaded("File:Histogram.h",{1303:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype1303\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Bin</div></div></div><div class=\"TTSummary\">Represents a single bin within a Histogram.</div></div>",1304:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1304\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\">Bin(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Value&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">start,</td></tr><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Value&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">end,</td></tr><tr><td class=\"first\"></td><td class=\"PType\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td></td><td class=\"PName last\">count</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Creates a Bin object.</div></div>",1305:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1305\" class=\"NDPrototype NoParameterForm\">Value start() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the start of the range of the bin.</div></div>",1306:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1306\" class=\"NDPrototype NoParameterForm\">Value end() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the end of the range of the bin (non-inclusive).</div></div>",1307:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1307\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">uint32</span> count() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the number of values that fall within the range of this bin.</div></div>",1308:"<div class=\"NDToolTip TType LC\"><div class=\"TTSummary\">Typedef for a vector of Bin objects.</div></div>",1309:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype1309\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">Histogram</div></div></div><div class=\"TTSummary\">Represents a Histogram object.</div></div>",1310:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1310\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\">Histogram(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Value&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">binsStart,</td></tr><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Value&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">binsSize</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Creates a Histogram object with no bins.</div></div>",1311:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1311\" class=\"NDPrototype NoParameterForm\">Value binsStart() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the value of the start of the first Bin in the Histogram.</div></div>",1312:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1312\" class=\"NDPrototype NoParameterForm\">Value binsSize() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the size of each Bin in the Histogram.</div></div>",1313:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1313\" class=\"NDPrototype NoParameterForm\">Bins bins() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the Bins contained within this Histogram.</div></div>",1314:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype1314\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">void</span> addBin(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Bin&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">bin</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Adds a single Bin to the Histogram.&nbsp; The first Bin\'s start value should match the binsStart used in the constructor.&nbsp; Every Bin added should have the same size which matches the binsSize used in the constructor.</div></div>"});