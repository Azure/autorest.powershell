import { TextWithRegions, TextPossibilities, Text, EOL } from "@microsoft.azure/codegen";

export class PsdFile extends TextWithRegions {
  private header: string;
  private footer: string;
  constructor(content?: TextPossibilities, objectIntializer?: Partial<PsdFile>) {
    content = content || '@{}';
    const [, header, contents, footer] = /(^.*?@{)(.*)(}\s*)/.exec(new Text(content).text.replace(/[\r?\n]/g, '«').replace(/^«*/, '').replace(/«*$/, '')) || [, '@{', '', '}'];
    super(contents.replace(/«/g, '\n'));
    this.header = header;
    this.footer = footer;
    this.apply(objectIntializer);
  }

  get text(): string {
    return [this.header, super.text, this.footer].join(EOL);
  }
}