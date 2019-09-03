import { TextWithRegions, TextPossibilities, Text, EOL } from '@azure-tools/codegen';

export class MdFile extends TextWithRegions {
  constructor(content?: TextPossibilities, objectIntializer?: Partial<MdFile>) {
    content = content || '';
    super(content, undefined, '<!--', '-->');
    this.apply(objectIntializer);
  }
}