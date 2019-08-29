import { TextWithRegions, TextPossibilities, Text, EOL } from '@azure/codegen';

export class PSScriptFile extends TextWithRegions {

  constructor(content?: TextPossibilities, objectIntializer?: Partial<PSScriptFile>) {
    content = content || '';
    super(content);
    this.apply(objectIntializer);
  }

}