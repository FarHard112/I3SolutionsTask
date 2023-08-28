export function isValidWalk(walk: string[]): boolean {
    if (walk.length !== 10) {
      return false;
    }
  
    const northCount = walk.filter(c => c === 'n').length;
    const southCount = walk.filter(c => c === 's').length;
    const eastCount = walk.filter(c => c === 'e').length;
    const westCount = walk.filter(c => c === 'w').length;
  
    return northCount === southCount && eastCount === westCount;
  }