const defaultMaximumCommentColumns = 80;
const defaultGeneratedIndentation = '        ';
const splitter = /\r\n|\r|\n/i;

export function wrapComments(indentation: string, prefix: string, comments: string): string {
  if (comments === null || comments.length === 0) {
    return '';
  }

  //cannot predict indentation because we cannot get last line generated
  const length = defaultMaximumCommentColumns - prefix.length - 1;
  const result = lineBreak(comments, length);
  for (let i = 0; i < result.length; i++) {
    if (i != 0) {
      result[i] = prefix + result[i];
    }
  }
  return result.join('\n' + indentation);
}

function lineBreak(comments: string, length: number): Array<string> {
  const lines = new Array<string>();
  for (const line of comments.split(splitter)) {
    let processedLine = line;
    while (processedLine.length > 0) {
      processedLine = processedLine.trim();
      const whiteSpacePositions = [...new Array(processedLine.length).keys()].filter(i => /\s/.test(processedLine[i])).concat([processedLine.length]);
      let preWidthWrapAt = 0;
      let postWidthWrapAt = 0;
      for (const index of whiteSpacePositions) {
        if (index <= length) {
          preWidthWrapAt = index;
        } else if (postWidthWrapAt === 0) {
          postWidthWrapAt = index;
        }
      }
      const wrapAt = preWidthWrapAt != 0 ? preWidthWrapAt : (postWidthWrapAt != 0 ? postWidthWrapAt : processedLine.length);
      lines.push(processedLine.substring(0, wrapAt));
      processedLine = processedLine.substring(wrapAt);
    }
  }
  return lines;
}