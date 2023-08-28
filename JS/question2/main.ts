export function findOutlier(integers: number[]): number {
  const oddNumbers = integers.filter(n => n % 2 !== 0);
  const evenNumbers = integers.filter(n => n % 2 === 0);
  return oddNumbers.length === 1 ? oddNumbers[0] : evenNumbers[0];
}